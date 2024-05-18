﻿using Microsoft.EntityFrameworkCore;
using ClinicaVet.Data;
using ClinicaVet.Model;


namespace ClinicaVet.Repositories;
public class UsuarioRepository : Repository<Usuario>
{
    public UsuarioRepository(MyDbContext context) : base(context)
    {
    }

    public async Task<Usuario> GetUserByEmailAndPassword(string email, string senha)
    {
        return await Context.Set<Usuario>().FirstOrDefaultAsync(u => u.Email == email && u.Senha == senha);
    }
}