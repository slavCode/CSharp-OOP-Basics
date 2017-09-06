public class VehicleSimulation
{
    public void Simulate(string command, Vehicle vehicle, double parameter)
    {
        switch (command)
        {
            case "Drive":
                vehicle.Drive(parameter);
                break;

            case "Refuel":
                vehicle.Refuel(parameter);
                break;
        }
    }
}
