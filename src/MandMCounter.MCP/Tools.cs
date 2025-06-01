using MandMCounter.Core;
using ModelContextProtocol.Server;
using System.Collections.Generic;

namespace MandMCounter.MCP
{
    // MCP tool for standard M&M counting
    [McpServerToolType]
    public class MandMCounterTool
    {
        [McpServerTool]
        public float GetDataForUnit(string unit, float quantity) => Calculator.CountMandMs(unit, quantity);

        [McpServerTool]
        public float GetDataForRectangle(string unit, float height, float width, float length) => Calculator.CountMandMs(unit, height, width, length);

        [McpServerTool]
        public float GetDataForCylinder(string unit, float height, float radius) => Calculator.CountMandMs(unit, height, radius);
    }

    // MCP tool for Peanut M&M counting
    [McpServerToolType]
    public class PeanutMandMCounterTool
    {
        [McpServerTool]
        public float GetDataForUnit(string unit, float quantity) => Calculator.CountPeanutMandMs(unit, quantity);

        [McpServerTool]
        public float GetDataForRectangle(string unit, float height, float width, float length) => Calculator.CountPeanutMandMs(unit, height, width, length);

        [McpServerTool]
        public float GetDataForCylinder(string unit, float height, float radius) => Calculator.CountPeanutMandMs(unit, height, radius);
    }

    // MCP tool for Skittle counting
    [McpServerToolType]
    public class SkittleCounterTool
    {
        [McpServerTool]
        public float GetDataForUnit(string unit, float quantity) => Calculator.CountSkittles(unit, quantity);

        [McpServerTool]
        public float GetDataForRectangle(string unit, float height, float width, float length) => Calculator.CountSkittles(unit, height, width, length);

        [McpServerTool]
        public float GetDataForCylinder(string unit, float height, float radius) => Calculator.CountSkittles(unit, height, radius);
    }

    // MCP tool for units
    [McpServerToolType]
    public class UnitsTool
    {
        [McpServerTool]
        public List<string> GetUnitsForVolume() => Units.GetUnitsForVolume();

        [McpServerTool]
        public List<string> GetUnitsForContainer() => Units.GetUnitsForContainer();
    }
}
