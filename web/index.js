let baton = document.querySelector('#bttnCalculate');

baton.addEventListener('click', () => {
    let text1 = document.querySelector("#Lala")
    let text2 = document.querySelector("#Jaja")
    if(text1.value.match(/\d/)){
   let a =  parseInt(text1.value)
   let b = parseInt(text2.value)
   console.log(a+ b);
    }
else alert("error");
    

})


