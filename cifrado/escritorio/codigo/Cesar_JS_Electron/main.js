var cesar = function (txt, dezp) {
    var alfabeto = "aábcdeéfghiíklmnñoópqrstuvwxyz".split('')
    var posicion = function( char ) {
        return alfabeto.indexOf( char );
    };
    var salida = ""
    txt.split('').forEach( function( item ) {
        salida += alfabeto.includes( item ) ? alfabeto[ ( posicion( item ) + parseInt(dezp,10) ) % alfabeto.length ] : item   
    })
    return salida
};