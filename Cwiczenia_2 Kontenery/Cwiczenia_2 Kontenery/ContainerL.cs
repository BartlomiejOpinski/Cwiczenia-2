using System.Runtime.CompilerServices;

namespace Cwiczenia_2_Kontenery;

public class ContainerL : Container
{


    public ContainerType type = ContainerType.L;
    
    public ContainerL(double loadWeightKg, double heightCm, double containerWeightKg, double depthInCm, double maxConWeight) 
        : base(loadWeightKg, heightCm, containerWeightKg, depthInCm, maxConWeight)
    {
        int idNumber = SerialCounter;
        
        serialNumber = "KON-" + type +"-"+ idNumber;
    }
}