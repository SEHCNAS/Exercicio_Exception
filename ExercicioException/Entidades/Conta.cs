using System;
using System.Collections.Generic;
using System.Text;
using ExercicioException.Entidades.exception;

namespace ExercicioException.Entidades {
    class Conta {
        public int NumeroConta { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque { get; set; }

        public Conta() {

        }
        public Conta(int numeroConta, string titular, double saldo, double limiteSaque) {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldo;
            LimiteSaque = limiteSaque;
        }

        public void Deposit(double valor) {

            Saldo += valor;
        }

        public void Saque(double valor) {
            if (valor > LimiteSaque) {

                throw new SaqueException("O valor ultrapassa o limite de saque ");
            }
            if (valor > Saldo ) {

                throw new SaqueException("Saldo insuficiente ");
            }
            Saldo -= valor;

        }

        public override string ToString() {
            return "NOVO SALDO: " + Saldo;
        }
    }
}
