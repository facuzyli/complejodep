public class LoginService
{
    public bool Autenticar(string usuario, string contraseña)
    {
        // Aquí debes verificar el usuario y la contraseña con la base de datos.
        // Por simplicidad, vamos a autenticar si el usuario es "admin" y la contraseña "1234".
        return usuario == "admin" && contraseña == "1234";
    }

    public void CerrarSesion()
    {
        // Implementa la lógica para cerrar sesión.
    }
}