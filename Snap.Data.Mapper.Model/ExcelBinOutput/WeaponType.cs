﻿namespace Snap.Data.Mapper.Model.ExcelBinOutput;

/// <summary>
/// 武器类型
/// https://github.com/Grasscutters/Grasscutter/blob/development/src/main/java/emu/grasscutter/game/props/WeaponType.java
/// </summary>
public enum WeaponType
{
    /// <summary>
    /// ?
    /// </summary>
    WEAPON_NONE = 0,

    /// <summary>
    /// 单手剑
    /// </summary>
    WEAPON_SWORD_ONE_HAND = 1,

    /// <summary>
    /// ?
    /// </summary>
    [Obsolete("尚未发现使用")]
    WEAPON_CROSSBOW = 2,

    /// <summary>
    /// ?
    /// </summary>
    [Obsolete("尚未发现使用")]
    WEAPON_STAFF = 3,

    /// <summary>
    /// ?
    /// </summary>
    [Obsolete("尚未发现使用")]
    WEAPON_DOUBLE_DAGGER = 4,

    /// <summary>
    /// ?
    /// </summary>
    [Obsolete("尚未发现使用")]
    WEAPON_KATANA = 5,

    /// <summary>
    /// ?
    /// </summary>
    [Obsolete("尚未发现使用")]
    WEAPON_SHURIKEN = 6,

    /// <summary>
    /// ?
    /// </summary>
    [Obsolete("尚未发现使用")]
    WEAPON_STICK = 7,

    /// <summary>
    /// ?
    /// </summary>
    [Obsolete("尚未发现使用")]
    WEAPON_SPEAR = 8,

    /// <summary>
    /// ?
    /// </summary>
    [Obsolete("尚未发现使用")]
    WEAPON_SHIELD_SMALL = 9,

    /// <summary>
    /// 法器
    /// </summary>
    WEAPON_CATALYST = 10,

    /// <summary>
    /// 双手剑
    /// </summary>
    WEAPON_CLAYMORE = 11,

    /// <summary>
    /// 弓
    /// </summary>
    WEAPON_BOW = 12,

    /// <summary>
    /// 长柄武器
    /// </summary>
    WEAPON_POLE = 13,
}