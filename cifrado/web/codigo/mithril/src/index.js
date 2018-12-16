import m from "mithril";

let texto = {
    estado: "",
    setValue: function(v) {
        texto.estado = v
    },
    view: function() {
        return [
            m('fieldset', [
                    m("legend","Texto Plano"),
                    m('label','Texto'),
                    m('input[type=text]',{
                        value: texto.estado,
                        oninput: m.withAttr('value', texto.setValue)
                    })]),
            m(cesar,{valor: texto.estado})
        ]
    }
}


var cesar = {
    alfabeto: "aábcdeéfghiíklmnñoópqrstuvwxyz".split(''),
    desplazamiento: "",
    setValue: function(v) {cesar.desplazamiento = v},
    cifrado: function(texto) {
        var posicion = function( char ) {return cesar.alfabeto.indexOf( char );}
        let salida = ''
        if( cesar.desplazamiento != "" ) {
            texto.split('').forEach( function( item ) {
                salida += cesar.alfabeto.includes( item ) 
                ? cesar.alfabeto[ (posicion(item)+ parseInt(cesar.desplazamiento,10)%cesar.alfabeto.length) ]
                : item
            })
        } else return texto
        return salida
    },
    view: function(vnode) {
        return m('div', [
            m('fieldset',[
                    m("legend","Cesar"),
                    m('div',  
                        m('label','Desplazamiento'),
                        m('input[type=number]', {
                            value: cesar.desplazamiento,
                            oninput: m.withAttr('value', cesar.setValue)
                        })),
                    m('textarea',{
                        value: cesar.cifrado(vnode.attrs.valor)
                    }),
                ]),
            m(inverso, { cifrado: cesar.cifrado(vnode.attrs.valor) }),
            m(grupos, { plano: vnode.attrs.valor} )
            
        ])
    }
}

var inverso = {
    estado: "",
    rev: function(texto) {
        inverso.estado = texto.split('').reverse().join('')
        return inverso.estado
    },
    view: function(vnode) {
        return m('div',
                m('fieldset',[
                     m("legend","Inverso"),
                     m('textarea',{
                        value: inverso.rev( vnode.attrs.cifrado )
                     })
                ]))
    }
}

var grupos = {
    estado: "",
    grupo: "",
    setValue: function(v){grupos.grupo = v},
    agrupar: function(texto) {
        if( grupos.grupo != "" ) {
            if( texto.length >= grupos.grupo )
                grupos.estado = texto.split('').reverse().join('')
            else return texto

        }else return texto
        return grupos.estado
    },
    view: function(vnode) {
        return m('div',
                m('fieldset',[
                        m('legend','Agrupamiento'),
                        m('label','N° Grupos'),
                        m('input[type=number]', {
                            value: grupos.grupo,
                            oninput: m.withAttr('value', grupos.setValue)
                        }),
                        m('div',
                            m('textarea',{
                            value: grupos.agrupar( vnode.attrs.plano ) 
                        }))
                    ])
            )
    }
}

let Form = {
    view: function() {
        return m("form",
            m(texto))
    }
}

m.mount( document.body, Form )
