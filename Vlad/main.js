 let firstInp
 let secondInp
 let otvet
 let txt 

let bttn = document.querySelector('#bttn') 
bttn.addEventListener('click', () => { //говорим кнопке что будет происходить в этой жизни
    firstInp = parseInt(first.value);
    secondInp = parseInt(second.value);
    otvet  = firstInp + secondInp;
    txt =  `${firstInp} + ${secondInp} = ${otvet}`;
    CreatePeshka(txt)
    
})

function CreatePeshka(txt) {
    let divka = document.querySelector('.disain') // найти в документе по #id или по .class
    let Peshka = document.createElement('p')
    Peshka.classList.add('aler')
    
    Peshka.innerHTML = txt
    divka.appendChild(Peshka) //добавили пешку(<p>) в дивку(<div></div>)
}
