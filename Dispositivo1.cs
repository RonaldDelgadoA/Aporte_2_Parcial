using System;

namespace Prueba_1
{
public class Dispositivo1 : Orden
    {
    public override string Repara(){
    var R1 = "- En repación el Dispositivo 1 :";
    return R1;
    }
    public override string Hardware(){
    var H1 = "- Agregando un Hardware Adicional al Dispositivo 1 :";
    return H1;
    }
}
}