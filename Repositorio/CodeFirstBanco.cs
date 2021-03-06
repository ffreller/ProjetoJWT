using System;
using System.Linq;
using ProjetoJWT.Models;

namespace ProjetoJWT.Repositorio
{
    public class CodeFirstBanco
    {
        public static void Inicializar(AutenticacaoContext contexto){

            if(contexto.Usuarios.Any()) return;

            var usuario = new Usuario(){
                Nome = "Fernando",
                Email = "fernando.guerra@corujasdev.com.br",
                Senha = "123456",
                DataNascimento = Convert.ToDateTime("10-10-1978"),
                Cpf = "333.333.333-23"
            };

            contexto.Usuarios.Add(usuario);

            var permissao = new Permissao(){
                Nome = "Comercial"
            };

            contexto.Permissoes.Add(permissao);

            var usuariopermissao = new UsuarioPermissao(){
                IdUsuario = usuario.IdUsuario,
                IdPermissao = permissao.IdPermissao
            };

            contexto.UsuariosPermissoes.Add(usuariopermissao);
            contexto.SaveChanges();
            
        }
    }
}