public class UsuarioBLL
{
    public void AgregarUsuario(Usuario usuario) {}
    public void EditarUsuario(Usuario usuario) {}
    public void EliminarUsuario(int id) {}
    public Usuario ObtenerUsuarioPorID(int id) { return null; }
    public List<Usuario> ListarUsuarios() { return null; }
    public void AsignarRol(Usuario usuario, string rol) {}
    public bool VerificarPermiso(Usuario usuario, string permiso) { return false; }
}