namespace Nine.Hosting
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class Program
    {
        private readonly IHostWindow hostWindow;

        public Program(IHostWindow hostWindow)
        {
            this.hostWindow = hostWindow;
        }

        public void Main(string[] args)
        {
            // Run "dnx --watch . dev" in this directory
            // Run "dnx --watch --port [PORT] . dev" to enable faster 
            // reload using Visual Studio compiler service.
            //
            // You can then modify the following code the see the changes
            // taking effect as you type and hit Ctrl+S.
            var form = new Form { BackColor = Color.DarkGray };
            hostWindow?.Attach(form.Handle);
            Application.Run(form);
        }
    }
}
