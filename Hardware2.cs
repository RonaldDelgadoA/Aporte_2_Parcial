using System;

namespace Prueba_1
{
    public class Hardware2: Decorador{
    
    public Hardware2(Orden _Orden):base(_Orden){ }
        
    public override string Hardware(){
    var Hardware2 = "Has Agregado unos Audifonos Adicional al Dispositivo";
    return Hardware2;
    }
}
}