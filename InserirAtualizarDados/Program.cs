using InserirAtualizarDados.Repositories;
using System;
using System.Windows.Forms;
using Unity;

namespace InserirAtualizarDados
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Resolvendo as dependências
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IBaseRepository, BaseRepository>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Configuração de dependências do formulário
            Application.Run(container.Resolve<Form1>());
        }
    }
}
