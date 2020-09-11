using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioException.Entidades.exception {
    class SaqueException : Exception {
        public SaqueException(string message) : base(message) {
        }
    }
}
