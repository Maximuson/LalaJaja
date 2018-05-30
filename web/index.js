let baton = document.querySelector('#divka');
console.log(baton);
let textbox = document.querySelector("#txt1")
let all = document.querySelectorAll('.krasota')
console.log(all[0], all[1])
baton.addEventListener('click', () => {
    baton.classList.remove('krasota')
    textbox.textContent = "REMEZ"

})

console.log(textbox)
