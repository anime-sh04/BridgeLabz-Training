class FactoryRobotHazardAnalyzer
{
    public double CalculateHazardRisk(double armPrecision, int workerDensity, string machineryState)
    {
        if (armPrecision < 0.0 || armPrecision> 1.0)
            throw new RobotSafetyException("Error: Arm precision must be 0.0–1.0");

        if (workerDensity <1 || workerDensity >20)
            throw new RobotSafetyException("Error: Worker density must be 1–20");

        if (!(machineryState.Equals("Worn") || machineryState.Equals("Faulty") ||machineryState.Equals("Critical")))
            throw new RobotSafetyException("Error: Unsupported machinery state");

        double machineRiskFactor = machineryState.Equals("Worn") ? 1.3 : machineryState.Equals("Faulty") ? 2.0 : 3.0;

        return ((1 - armPrecision) * 15) + (workerDensity * machineRiskFactor);
    }
}
