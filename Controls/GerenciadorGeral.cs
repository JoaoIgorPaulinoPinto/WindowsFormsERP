using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto0307
{
    class GerenciadorGeral
    {  // Declaramos a thread aqui dentro da classe
        private static Thread newFormThread;

        public static void CarregarNovaTela<T>(Form currentForm) where T : Form, new()
        {
            // Fecha o formulário atual de forma segura
            currentForm.Invoke(new Action(() =>
            {
                currentForm.Close();
            }));

            // Cria e inicia a nova thread
            newFormThread = new Thread(() =>
            {
                Application.Run(new T());
            });
            newFormThread.SetApartmentState(ApartmentState.STA);
            newFormThread.Start();
        }
    }
}
