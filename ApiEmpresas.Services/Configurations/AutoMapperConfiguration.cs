namespace ApiEmpresas.Services.Configurations
{
    /// <summary>
    /// Classe de configuração do automapper
    /// </summary>
    public class AutoMapperConfiguration
    {
        /// <summary>
        /// Método para configuração do uso automapper
        /// </summary>
        public static void AddAutoMapper(WebApplicationBuilder builder)
        {
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
