namespace UMBIT.ManagerAdmin.InterfaceWeb.Recursos.CustomAtributte
{
    public class ServiceAttribute : Attribute
    {
        public string Nome { get; set; }
        public ServiceAttribute(string nome)
        {
                this.Nome = nome;   
        }
    }
}
