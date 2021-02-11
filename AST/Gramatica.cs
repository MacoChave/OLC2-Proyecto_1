using Irony.Parsing;
using System;

namespace Proyecto_1.AST
{
    class Gramatica : Grammar
    {
        public Gramatica() : base(caseSensitive: false)
        {
            #region ER
            var numero = new NumberLiteral(Constante.nodo_numero);
            var cadena = new NumberLiteral(Constante.nodo_cadena);
            var real = new NumberLiteral(Constante.nodo_real);
            var bandera = new NumberLiteral(Constante.nodo_bandera);
            #endregion

            #region Terminales
            var res_string = ToTerm(Constante.res_string);
            var res_integer = ToTerm(Constante.res_integer);
            var res_real = ToTerm(Constante.res_real);
            var res_boolean = ToTerm(Constante.res_boolean);
            var res_array = ToTerm(Constante.res_array);
            var res_of = ToTerm(Constante.res_of);
            var res_void = ToTerm(Constante.res_void);
            var res_program = ToTerm(Constante.res_program);
            var res_type = ToTerm(Constante.res_type);
            var res_object = ToTerm(Constante.res_object);
            var res_var = ToTerm(Constante.res_var);
            var res_begin = ToTerm(Constante.res_begin);
            var res_end = ToTerm(Constante.res_end);
            var res_function = ToTerm(Constante.res_function);
            var res_if = ToTerm(Constante.res_if);
            var res_then = ToTerm(Constante.res_then);
            var res_else = ToTerm(Constante.res_else);
            var res_case = ToTerm(Constante.res_case);
            var res_while = ToTerm(Constante.res_while);
            var res_do = ToTerm(Constante.res_do);
            var res_repeat = ToTerm(Constante.res_repeat);
            var res_until = ToTerm(Constante.res_until);
            var res_for = ToTerm(Constante.res_for);
            var res_break = ToTerm(Constante.res_break);
            var res_continue = ToTerm(Constante.res_continue);
            var res_write = ToTerm(Constante.res_write);
            var res_writeln = ToTerm(Constante.res_writeln);
            var res_exit = ToTerm(Constante.res_exit);
            var res_graficar = ToTerm(Constante.res_graficar);
            #endregion

            #region No Terminales
            NonTerminal START = new NonTerminal(Constante.nodo_operacion);
            NonTerminal NAME = new NonTerminal(Constante.nodo_operacion);
            NonTerminal LIST_DEF = new NonTerminal(Constante.nodo_operacion);
            NonTerminal DEF = new NonTerminal(Constante.nodo_operacion);
            NonTerminal LIST_SENT = new NonTerminal(Constante.nodo_operacion);
            NonTerminal SENT = new NonTerminal(Constante.nodo_operacion);
            NonTerminal OPERACION = new NonTerminal(Constante.nodo_operacion);
            #endregion
        }

    }
}
