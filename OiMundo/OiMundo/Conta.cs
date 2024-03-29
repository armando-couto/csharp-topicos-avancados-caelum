﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OiMundo
{
    abstract class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; protected set; }

        public Cliente Titular { get; set; }

        public void Saca(double valorASerSacado)
        {
            if (valorASerSacado < 0.0)
            {
                throw new ArgumentException();
            }
            if (valorASerSacado > this.Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                this.Saldo -= valorASerSacado;
            }
        }

        public virtual void Deposita(double valorASerDepositado)
        {
            this.Saldo += valorASerDepositado;
        }

        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }
    }
}
