using System;
namespace Prueba_1 {
public class Decorador : Orden{

    protected Orden _Orden;
    public Decorador(Orden _Orden)
    {
        this._Orden= _Orden;
    }
    public override string Hardware(){
      return _Orden.Hardware();
    }
    public override string Repara(){
      return _Orden.Repara();
    }
}
}