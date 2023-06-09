﻿using MediatR;

namespace DesafioCliente.Commands
{
    public class AlteraClienteCommand : IRequest <String>
    {
        public int ClienteId { get; set; }
        public string ClienteName { get; set; } = string.Empty;
        public string ClienteLastName { get; set; } = string.Empty;
        public int ClientePhone { get; set; }
        public string ClienteEmail { get; set; } = string.Empty;
        public string ClienteCep { get; set; } = string.Empty;
        public int ClienteCPF { get; set; }
    }
}
