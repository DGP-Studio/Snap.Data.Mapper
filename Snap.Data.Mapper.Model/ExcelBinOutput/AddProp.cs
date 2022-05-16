﻿namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class AddProp : DataObject
{
    [JsonPropertyName("propType")]
    public string? PropType { get; set; }

    [JsonPropertyName("value")]
    public double? Value { get; set; }
}