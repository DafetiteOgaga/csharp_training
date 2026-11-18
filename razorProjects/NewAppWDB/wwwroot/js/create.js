console.log("from create page");
const studentForm = document.getElementById("studentForm");
if (studentForm !== null) {
    studentForm.addEventListener("submit", (event) => {
        event.preventDefault();
        const studentNameInput = document.getElementById("studentNameInput");
        const agreeTerms = document.getElementById("agreeTerms");
        const studentEmail = document.getElementById("studentEmail");
        const stateOfOrigin = document.getElementById("stateOfOrigin");
        const formData = new FormData(studentForm);
        console.log(formData.get("studentName"));
        console.log(formData.get("studentEmail"));
        console.log(formData.get("gender"));
        console.log(formData.get("stateOfOrigin"));
        console.log(formData.get("agreeTerms"));
        formData.append("registrationStatus", "pending");
        formData.forEach((value, key) => {
            console.log(key, value);
        });
        formData.set("registrationStatus", "success");
        console.log(formData.get("registrationStatus"));
        formData.delete("gender");
        formData.has("agreeTerms");
        formData.getAll("gender");
        const studentName = studentNameInput?.value.trim();
        const registeredName = document.getElementById("registeredName");
        if (!studentName) {
            console.log("Pls, enter a student name");
            if (registeredName !== null) {
                registeredName.textContent = "PLs, enter a student name";
                registeredName.className = "mt-2 text-danger";
            }
            return;
        }
        // if (studentEmail!==null) {
        //     studentEmail.setCustomValidity("This email is incorrect. Please provide a valid student email address.");
        // }
        if (studentNameInput !== null && studentEmail !== null && registeredName !== null) {
            registeredName.textContent =
                `Name: ${studentNameInput.value} | Email: ${studentEmail.value}`;
            registeredName.className = "mt-3 text-success";
            if (agreeTerms !== null) {
                console.log(agreeTerms.checked);
            }
            studentNameInput.value = "";
            studentEmail.value = "";
        }
        if (stateOfOrigin !== null) {
            console.log(stateOfOrigin.value);
            console.log(stateOfOrigin.options);
        }
    });
}
const agreeTerms = document.getElementById("agreeTerms");
if (agreeTerms !== null) {
    agreeTerms.addEventListener("click", () => {
        console.log(`box checked: ${agreeTerms.checked}`);
    });
}
const aspNetFormFirstName = document.querySelector("#Student_FirstName");
if (aspNetFormFirstName !== null) {
    aspNetFormFirstName.addEventListener("input", () => {
        console.log(aspNetFormFirstName.value);
    });
}
const aspNetFormLastName = document.querySelector("#Student_LastName");
if (aspNetFormLastName !== null) {
    aspNetFormLastName.addEventListener("input", () => {
        console.log(aspNetFormLastName.value);
    });
}
export {};
//# sourceMappingURL=create.js.map