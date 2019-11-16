document.addEventListener("DomContentLoadede", function () {
    var element = document.createElement("p");
    element.textContent("Это JS элемент");
    document.querySelector("body").appendChild(element);
});