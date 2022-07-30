using System;

namespace Prueba_1 {

public class RestablecerDispositivo: Decorador{

    public RestablecerDispositivo(Orden Orden):base(Orden){ }
    public override string Repara(){
    var R1 = "El Dispositivo esta Formatiado por Completo";
    return R1;
    }
}
}