using System;

namespace Prueba_1
{
    public class Hardware3: Decorador{
    
    public Hardware3(Orden _Orden):base(_Orden){ }
        
    public override string Hardware(){
    var Hardware3 = "Has Agregado un Adaptador OTG Adicional al Dispositivo";
    return Hardware3;
    }
}
}