using System;

namespace Prueba_1 {

public class Bateria: Decorador{

    public Bateria(Orden Orden):base(Orden){ }
    public override string Repara(){
    var B1 = "La bateria del Dispositivo fue cambiada por completo";
    return B1;
    }
}
}