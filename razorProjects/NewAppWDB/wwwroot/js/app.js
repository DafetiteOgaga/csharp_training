console.log("hello from typescript and ts handshake to rp success");
const heading = document.getElementById("myHeading");
if (heading !== null) {
    console.log(heading);
    console.log(heading.textContent);
    heading.textContent = "You are Welcome to";
}
const changeBtn = document.getElementById("changeButton");
if (changeBtn !== null) {
    changeBtn.addEventListener("click", (event) => {
        if (heading !== null) {
            if (heading.textContent?.toLowerCase() === "you are welcome to") {
                heading.textContent = "You clicked the button";
                changeBtn.textContent = "Undo";
            }
            else {
                heading.textContent = "You are Welcome to";
                changeBtn.textContent = "Change";
            }
            changeBtn.classList.toggle("btn-danger");
        }
        console.log("Event details:", event);
        console.log("Clicked element:", event.target);
        console.log("Target:", event.target);
        console.log("Current Target:", event.currentTarget);
    });
}
const heading2 = document.querySelector("#myHeading");
if (heading2 !== null) {
    console.log(heading2);
    // heading2.textContent = "TypeScript is getting interesting!";
}
const allButtons = document.querySelectorAll("button");
console.log(allButtons);
allButtons.forEach((button, index) => {
    console.log(`Button ${index + 1}:`, button.textContent);
    // button.textContent = "Clicked";
});
// if (heading2!==null) {
// 	heading2.classList.add("text-primary");
// 	heading2.classList.remove("display-4")
// }
const nameInput = document.querySelector("#studentName");
const paragraphDisplay = document.querySelector("#greeting");
console.log(nameInput);
if (nameInput !== null) {
    nameInput.addEventListener("input", () => {
        console.log(nameInput.value);
        if (paragraphDisplay !== null) {
            paragraphDisplay.classList.add("text-success");
            paragraphDisplay.textContent = `Recap: ${nameInput.value}`;
            if (nameInput.value.trim() === "") {
                paragraphDisplay.classList.add("d-none");
            }
            else {
                paragraphDisplay.classList.remove("d-none");
            }
        }
    });
    nameInput.addEventListener("focus", () => {
        console.log("Input is focused!");
    });
    nameInput.addEventListener("blur", () => {
        console.log("input has lost focus and is blurred!");
    });
}
const totalRegisteredStudents = document.querySelector("#totalRegisteredStudents");
if (totalRegisteredStudents !== null) {
    totalRegisteredStudents.style.color = "purple";
}
export {};
// const newParagraph = document.createElement("p");
// newParagraph.textContent = "I was created using Typescript!";
// document.body.appendChild(newParagraph);
// const newParagraph1 = document.createElement("p");
// newParagraph1.textContent = "I was added using append()!";
// document.body.append(newParagraph1);
//# sourceMappingURL=app.js.map