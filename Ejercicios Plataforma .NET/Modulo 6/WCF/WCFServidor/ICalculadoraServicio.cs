using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServidor
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICalculadoraServicio
    {
        [OperationContract]
        double Sumar(double operador1, double operador2);

        [OperationContract]
        double Restar(double operador1, double operador2);

        [OperationContract]
        double Multiplicar(double operador1, double operador2);

        [OperationContract]
        [FaultContract(typeof(DatosServicios))]
        double Dividir(double numerador, double denominador);

    }

    [DataContract]
    public class DatosServicios
    {
        [DataMember]
        public string MensajeError {get; set;}

        [DataMember]
        public string DetallesError{get; set;}

    }
}
