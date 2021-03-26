// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SapTableSourceConverter))]
    public partial class SapTableSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RowCount))
            {
                writer.WritePropertyName("rowCount");
                writer.WriteObjectValue(RowCount);
            }
            if (Optional.IsDefined(RowSkips))
            {
                writer.WritePropertyName("rowSkips");
                writer.WriteObjectValue(RowSkips);
            }
            if (Optional.IsDefined(RfcTableFields))
            {
                writer.WritePropertyName("rfcTableFields");
                writer.WriteObjectValue(RfcTableFields);
            }
            if (Optional.IsDefined(RfcTableOptions))
            {
                writer.WritePropertyName("rfcTableOptions");
                writer.WriteObjectValue(RfcTableOptions);
            }
            if (Optional.IsDefined(BatchSize))
            {
                writer.WritePropertyName("batchSize");
                writer.WriteObjectValue(BatchSize);
            }
            if (Optional.IsDefined(CustomRfcReadTableFunctionModule))
            {
                writer.WritePropertyName("customRfcReadTableFunctionModule");
                writer.WriteObjectValue(CustomRfcReadTableFunctionModule);
            }
            if (Optional.IsDefined(PartitionOption))
            {
                writer.WritePropertyName("partitionOption");
                writer.WriteStringValue(PartitionOption.Value.ToString());
            }
            if (Optional.IsDefined(PartitionSettings))
            {
                writer.WritePropertyName("partitionSettings");
                writer.WriteObjectValue(PartitionSettings);
            }
            if (Optional.IsDefined(QueryTimeout))
            {
                writer.WritePropertyName("queryTimeout");
                writer.WriteObjectValue(QueryTimeout);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(SourceRetryCount))
            {
                writer.WritePropertyName("sourceRetryCount");
                writer.WriteObjectValue(SourceRetryCount);
            }
            if (Optional.IsDefined(SourceRetryWait))
            {
                writer.WritePropertyName("sourceRetryWait");
                writer.WriteObjectValue(SourceRetryWait);
            }
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections");
                writer.WriteObjectValue(MaxConcurrentConnections);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static SapTableSource DeserializeSapTableSource(JsonElement element)
        {
            Optional<object> rowCount = default;
            Optional<object> rowSkips = default;
            Optional<object> rfcTableFields = default;
            Optional<object> rfcTableOptions = default;
            Optional<object> batchSize = default;
            Optional<object> customRfcReadTableFunctionModule = default;
            Optional<SapTablePartitionOption> partitionOption = default;
            Optional<SapTablePartitionSettings> partitionSettings = default;
            Optional<object> queryTimeout = default;
            string type = default;
            Optional<object> sourceRetryCount = default;
            Optional<object> sourceRetryWait = default;
            Optional<object> maxConcurrentConnections = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rowCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rowCount = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("rowSkips"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rowSkips = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("rfcTableFields"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rfcTableFields = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("rfcTableOptions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rfcTableOptions = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("batchSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    batchSize = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("customRfcReadTableFunctionModule"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    customRfcReadTableFunctionModule = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("partitionOption"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    partitionOption = new SapTablePartitionOption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("partitionSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    partitionSettings = SapTablePartitionSettings.DeserializeSapTablePartitionSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("queryTimeout"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    queryTimeout = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceRetryCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sourceRetryCount = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sourceRetryWait"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sourceRetryWait = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxConcurrentConnections = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SapTableSource(type, sourceRetryCount.Value, sourceRetryWait.Value, maxConcurrentConnections.Value, additionalProperties, queryTimeout.Value, rowCount.Value, rowSkips.Value, rfcTableFields.Value, rfcTableOptions.Value, batchSize.Value, customRfcReadTableFunctionModule.Value, Optional.ToNullable(partitionOption), partitionSettings.Value);
        }

        internal partial class SapTableSourceConverter : JsonConverter<SapTableSource>
        {
            public override void Write(Utf8JsonWriter writer, SapTableSource model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SapTableSource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSapTableSource(document.RootElement);
            }
        }
    }
}
