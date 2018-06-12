let res = document.querySelector('#res')
let firstinp = document.querySelector('#firstinp')
let secondinp = document.querySelector('#secondinp')
let main = document.querySelector('#maindva')
let body = document.querySelector('body')
let a
let b
let c


res.addEventListener('click', () => {
 a = firstinp.value
 b = secondinp.value
    if(!a.match(/\d/) || !b.match(/\d/) || a.match(/\w[а-яА-Я]/) || b.match(/\w[а-яА-Я]/)) {
    alert('бИБА, введи цифры')
}
else{
    c = parseInt(a) + parseInt(b)
    console.log(c)

    txt = `${a} + ${b} = ${c}` 
    

    let divres = document.createElement('div')
    let egg = document.createElement('p')
    divres.classList.add('margindva')
    egg.innerHTML = txt
    divres.appendChild(egg)
    container.appendChild(divres)

}


 
})
