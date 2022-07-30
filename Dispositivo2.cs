using System;

namespace Prueba_1
{
public class Dispositivo2 : Orden
    {
    public override string Repara(){
    var R1 = "- En repación el Dispositivo 2 :";
    return R1;
    }
   public override string Hardware(){
    var H1 = "- Agregando un Hardware Adicional al Dispositivo 2 :";
    return H1;
    }
}
}