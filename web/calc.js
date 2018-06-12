let firstInput = document.querySelector('#input1')
let secondInput = document.querySelector('#input2')
let result = document.querySelector('#result')
const bttn = document.querySelector("#bttn")
let list = document.querySelector('#listRes')
let zone = document.querySelector('#main')
const Som = document.querySelector('#Som')
let txt = 0;
let arr = [];

let a = 0;
let b = 0;
let counter = 0;

//BroadcastChannel

    let listState = [];
    let value = localStorage.getItem('listState');
  


Del.addEventListener('click', () => {
    
let Lala = firstInput.value;
let Jaja = secondInput.value;
a =  parseInt(Lala)
b = parseInt( Jaja)
let C = a + b

let paket = document.createElement('li')
paket.innerHTML = `${Lala} + ${Jaja} =  ${C}`
list.appendChild(paket);
Gimn.play()



})
function createChild(txt) {
    let item = document.createElement('li')
    item.classList.add('li')
    item.innerHTML= txt
    list.appendChild(item);
    counter++;
}

bttn.addEventListener('click', () => 
{   

    if (zone.classList.contains('err')) {
        zone.classList.remove('err')
    }
    if(!firstInput.value.match(/\d/) || !secondInput.value.match(/\d/) ){
        zone.classList.add('err')
    }
    else {
        a =  parseInt(firstInput.value)
        b = parseInt( secondInput.value);
        result.value = a + b;
        txt = `${a} + ${b} = ${result.value}`;
        createChild(txt)
        arr.push(txt);
        console.log(arr)
        
       
        
       
       
    }

function render(arr) {

}
})