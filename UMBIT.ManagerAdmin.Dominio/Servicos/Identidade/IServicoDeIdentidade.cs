namespace UMBIT.ManagerAdmin.Dominio.Servicos.Identidade
{
    public interface IServicoDeIdentidade
    {
        void Valide(string login);
        void Login(string login, string password);
        void Registro(string login, string password);
    }
}
