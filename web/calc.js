let firstInput = document.querySelector('#input1')
let secondInput = document.querySelector('#input2')
let result = document.querySelector('#result')
const bttn = document.querySelector("#bttn")
let a = 0;
let b = 0;
//BroadcastChannel

bttn.addEventListener('click', () => 
{
    a =  parseInt(firstInput.value)
    b = parseInt( secondInput.value);
 result.value = a + b;
 console.log(result.value);
})