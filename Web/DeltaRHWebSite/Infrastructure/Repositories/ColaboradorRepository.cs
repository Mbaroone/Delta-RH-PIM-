﻿using DeltaRHWebSite.Models;
using DeltaRHWebSite.Models.Repositories;

namespace DeltaRHWebSite.Infrastructure.Repositories
{
    public class ColaboradorRepository : IColaboradorRepository
    {

        private readonly ContextoConexao _contexto = new ContextoConexao();

        public void Add(Colaborador colaborador)
        {
            _contexto.Colaboradores.Add(colaborador);
            _contexto.SaveChanges();
        }

        public void Delete(Colaborador colaborador)
        {
            _contexto.Colaboradores.Remove(colaborador);
            _contexto.SaveChanges();
        }

        public Colaborador Get(int id)
        {
           return _contexto.Colaboradores.Single(colab => colab.id == id);
        }

        public List<Colaborador> GetAll()
        {
            return _contexto.Colaboradores.ToList();
        }

        public void Update(Colaborador colaborador)
        {
            throw new NotImplementedException();
        }
    }
}
