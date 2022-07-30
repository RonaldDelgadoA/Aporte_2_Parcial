using System;

namespace Prueba_1 {

public class PantallaRota: Decorador{

    public PantallaRota(Orden Orden):base(Orden){ }
    public override string Repara(){
    var R1 = "La Pantalla Rota ya esta reapada por completo";
    return R1;
    }
}
}