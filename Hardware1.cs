using System;

namespace Prueba_1
{
    public class Hardware1: Decorador{
    
    public Hardware1(Orden _Orden):base(_Orden){ }
        
    public override string Hardware(){
    var Hardware1 = "Has Agregado el Cargador Adicional al Dispositivo";
    return Hardware1;
    }
}
}