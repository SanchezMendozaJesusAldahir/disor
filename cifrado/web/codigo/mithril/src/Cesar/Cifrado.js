import m from "mithril";

let Alfabeto = require("./Cesar/Alfabeto")

let Cifrado = {
    cifrado: function (vnode) {
        var posicion = function( char ) {
            return Alfabeto.alfabeto.indexOf( char );
        };
        var salida = ""
        var text = vnode.attrs.text
        var dezp = vnode.attrs.deplazamiento

        text.split('').forEach( function( item ) {
            salida += alfabeto.includes( item ) ? alfabeto[ ( posicion( item ) + parseInt(dezp,10) ) % Alfabeto.alfabeto.length ] : item   
        })
        return salida
    }
}

module.exports = Cifrado