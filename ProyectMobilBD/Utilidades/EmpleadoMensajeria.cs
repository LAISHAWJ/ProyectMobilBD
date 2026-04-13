using CommunityToolkit.Mvvm.Messaging.Messages;

namespace ProyectMobilBD.Utilidades
{
    public class EmpleadoMensajeria : ValueChangedMessage<EmpleadoMensaje>
    {
        public EmpleadoMensajeria(EmpleadoMensaje value) : base(value)
        {

        }
    }
}
