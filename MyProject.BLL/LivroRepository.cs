using Microsoft.EntityFrameworkCore;
using MyProject.DAL.DBContext;
using MyProject.MODEL;


namespace MyProject.BLL
{
    public static class LivroRepository
    {


        public static List<Livro> GetAll()
        {
            using (var dbContext = new MyDbContext())
            {
                var Livro = dbContext.Livros.ToList();
                return Livro;

            }
        }

        public static Livro GetById(int Id)
        {
            using (var dbContext = new MyDbContext())
            {
                var Livro = dbContext.Livros.Single(p => p.Id == Id);   
                return Livro;

            }
        }

        public static Livro Insert(Livro _Livro)
        {
            using (var dbContext = new MyDbContext())
            {
                dbContext.Add(_Livro);
                dbContext.SaveChanges();
            }
            return _Livro;
        }

        public static void Update(Livro _Livro)
        {
            using (var dbContext = new MyDbContext())
            {
                var Livro = dbContext.Livros.Single(p => p.Id == _Livro.Id);
                Livro.Titulo = _Livro.Titulo;
                Livro.Ano = _Livro.Ano;
                Livro.Autor= _Livro.Autor;
                Livro.Editora = _Livro.Editora;
                Livro.Resumo = _Livro.Resumo;
                dbContext.SaveChanges();
            }
        }

        public static void Excluir(Livro _Livro)
        {
            using (var dbContext = new MyDbContext())
            {
                var Livro = dbContext.Livros.Single(p => p.Id == _Livro.Id);
                dbContext.Remove(Livro);
                dbContext.SaveChanges();
            }
        }

       

    }
}