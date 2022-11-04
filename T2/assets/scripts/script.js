// 02/11/2022

const HTMLID_ZONA_GLIFOS = "zona_glifos"
const HTMLID_INPUT_TIPO_LETRA = "input_tipo_letra";
const HTMLID_INPUT_INICIO = "input_inicio";
const HTMLID_INPUT_FINAL = "input_final";

function on_boton_mostrar_click() {
    /** @type {HTMLDivElement} */
    let glifos = document.getElementById(HTMLID_ZONA_GLIFOS);
    glifos.textContent = null;

    mostrar_glifos(glifos,
        document.getElementById(HTMLID_INPUT_INICIO).valueAsNumber,
        document.getElementById(HTMLID_INPUT_FINAL).valueAsNumber,
        document.getElementById(HTMLID_INPUT_TIPO_LETRA).value);
} // on_boton_mostrar_click

/**
 * 
 * @param {HTMLElement} donde 
 * @param {Number} inicio 
 * @param {Number} fin 
 * @param {String} tipo_letra 
 */
function mostrar_glifos(donde, inicio, fin, tipo_letra) {
    donde.textContent = null;

    inicio = Math.trunc(Number(inicio));
    fin = Math.trunc(Number(fin));

    if (isNaN(inicio) || (inicio < 0) || (inicio > 0xFFFFFFFF)) throw "Parámetro inválido o fuera de rango: inicio"
    if (isNaN(fin) || (fin < 0) || (fin > 0xFFFFFFFF)) throw "Parámetro inválido o fuera de rango: fin"
    if ((typeof tipo_letra !== "string") || (tipo_letra.length == 0)) throw "Parámetro inválido o fuera de rango: tipo_letra"

    for (let i = inicio; i <= fin; i++) {
        /** @type {HTMLDivElement} */
        let glifo = document.createElement("div");
        glifo.className = "glifo";

        let texto = document.createElement("span");
        texto.className = "texto";
        texto.style = `font-family: '${tipo_letra}'`;
        texto.innerText = String.fromCodePoint(i);
        glifo.append(texto);

        let codePoint = document.createElement("span");
        codePoint.innerText = "&x" + i.toString(16) + ";";
        glifo.append(codePoint);

        donde.append(glifo);
    } // for i
} // on_boton_mostrar_click