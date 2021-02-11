# Gramática proyecto

## Configuración del lenguaje

    caseSensitive -> false

## Comentarios

    singleComment -> //
    multiComment -> {**}
    multiCommentv2 -> {..}

## Tipos de dato

    tp_string -> ' (A-Za-z0-9)+ '
    tp_integer -> (-)?[0-9]+
    tp_real -> integer . [0-9]+
    tp_boolean -> true | false

## Palabras reservadas

    string
    integer
    real
    boolean
    array
    of
    void
    program
    type
    object
    var
    begin
    end
    function
    if
    then
    else
    case
    while
    do
    repeat
    until
    for
    break
    continue
    write
    writeln
    exit
    graficar_ts

## Estructura

El programa consiste de las partes:

- Program name
- Type declarations
- Constant declarations
- Variables declarations
- Functions declarations
- Procedures declarations
- Main program block
- Statements and Expressions within each block
- Comments

Formato básico:

    program [name];

    var [global variables declaration block]

    function
        {local variables}
    begin
        {list sentences}
    end;

    procedure
        {local variables}
    begin
        {list sentences}
    end;

    begin
        {list sentences}
    end.

## Gramática

    START           -> NAME LIST_DEF BODY
    NAME            -> rs_program id tk_semicolon
    LIST_DEF        -> DEF LIST_DEF
                     | DEF
    DEF             -> VARIABLE
                     | FUNCION
                     | PROCEDIMIENTO
                     | EMPTY
    BODY            -> res_begin LIST_SENT res_end
    LIST_SENT       -> SENT LIST_SENT
                     | SENT
    SENT            -> IF
                     | SWITCH
                     | WHILE
                     | REPEAT
                     | FOR
                     | WRITE
                     | EXIT
                     | GRAFICAR
