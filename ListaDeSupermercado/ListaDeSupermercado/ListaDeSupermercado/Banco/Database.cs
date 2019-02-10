using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ListaDeSupermercado.Banco
{
    class Database
    {
        private SQLiteConnection _conexao;

        public Database()
        {
            _conexao = new SQLiteConnection();
        }
    }
}
