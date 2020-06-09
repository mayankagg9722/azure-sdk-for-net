// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ConnectionMonitorOutput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (WorkspaceSettings != null)
            {
                writer.WritePropertyName("workspaceSettings");
                writer.WriteObjectValue(WorkspaceSettings);
            }
            writer.WriteEndObject();
        }

        internal static ConnectionMonitorOutput DeserializeConnectionMonitorOutput(JsonElement element)
        {
            string type = default;
            ConnectionMonitorWorkspaceSettings workspaceSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workspaceSettings = ConnectionMonitorWorkspaceSettings.DeserializeConnectionMonitorWorkspaceSettings(property.Value);
                    continue;
                }
            }
            return new ConnectionMonitorOutput(type, workspaceSettings);
        }
    }
}