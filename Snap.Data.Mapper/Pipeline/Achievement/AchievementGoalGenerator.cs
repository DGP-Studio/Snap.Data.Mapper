﻿using Microsoft;
using Snap.Data.Mapper.Model.Common;
using Snap.Data.Mapper.Model.ExcelBinOutput.Achievement;
using Snap.Data.Mapper.Model.ExcelBinOutput.Reward;
using Snap.Data.Mapper.Pipeline.Abstraction;
using Snap.Data.Mapper.Pipeline.Achievement.Model;
using System.Collections.Generic;
using System.Text.Json;

namespace Snap.Data.Mapper.Pipeline.Achievement;

public class AchievementGoalGenerator
{
    private readonly string outputFolder;
    private readonly JsonSerializerOptions options;

    private readonly IEnumerable<AchievementGoalExcelConfigData> goals;
    private readonly IDictionary<int, RewardExcelConfigData> rewardMap;

    public AchievementGoalGenerator(
        string outputFolder, JsonSerializerOptions options,
        IEnumerable<AchievementGoalExcelConfigData> goals,
        IDictionary<int, RewardExcelConfigData> rewardMap)
    {
        this.outputFolder = outputFolder;
        this.options = options;
        this.goals = goals;
        this.rewardMap = rewardMap;
    }

    public void Generate()
    {
        List<AchievementGoal> achievementGoalCache = new();
        foreach (AchievementGoalExcelConfigData item in goals)
        {
            SimpleReward? simpleReward = null;

            if (item.FinishRewardId.HasValue)
            {
                RewardExcelConfigData rewardExcelConfigData = rewardMap[item.FinishRewardId.Value];
                Verify.Operation(rewardExcelConfigData.RewardItemList[1].ItemId == null, "出现多个奖励内容");

                ItemIdItemCount reward = rewardExcelConfigData.RewardItemList[0];

                simpleReward = new()
                {
                    Id = reward.ItemId!.Value,
                    Count = reward.ItemCount!.Value,
                };
            }

            AchievementGoal achievementGoal = new()
            {
                Order = item.OrderId,
                Name = item.NameTextMapHash.Value,
                FinishReward = simpleReward,
                Icon = string.IsNullOrEmpty(item.IconPath) ? null : item.IconPath,
            };

            achievementGoalCache.Add(achievementGoal);
        }

        IPipeline.GenerateFile<AchievementGoal>(achievementGoalCache, outputFolder, options);
    }
}