function add() {
    document.getElementById("expContent").innerHTML += `
                <div class="row">
                    <div class="col">
                        <label for="compName" class="text-primary">Company Name</label><br />
                        <input type="text" class="form-control" placeholder="Enter Full Name" />
                    </div>
                    <div class="col">
                        <label for="compDesignation" class="text-primary">Designation</label><br />
                        <input type="text" class="form-control" placeholder="Enter Designation" />
                    </div>
                    <div class="col">
                        <label for="compFrom" class="text-primary">From</label><br />
                        <input asp-for="From" class="form-control" />
                        <span asp-validation-for="From"></span>
                    </div>
                    <div class="col">
                        <label for="compTo" class="text-primary">To</label><br />
                        <input asp-for="To" class="form-control" />
                        <span asp-validation-for="To"></span>
                    </div>
                </div>
            `;
}

function change(id) {
    if (document.getElementById(id).checked == true) {
        document.getElementById(id + "Read").disabled = false;
        document.getElementById(id + "Write").disabled = false;
        document.getElementById(id + "Speak").disabled = false;
    }
    else {
        document.getElementById(id + "Read").checked = false;
        document.getElementById(id + "Read").disabled = true;

        document.getElementById(id + "Write").checked = false;
        document.getElementById(id + "Write").disabled = true;

        document.getElementById(id + "Speak").checked = false;
        document.getElementById(id + "Speak").disabled = true;
    }
}

function techChange(id) {
    if (document.getElementById(id).checked == true) {
        document.getElementById(id + "Begginer").disabled = false;
        document.getElementById(id + "Mediator").disabled = false;
        document.getElementById(id + "Expert").disabled = false;
    }
    else {
        document.getElementById(id + "Begginer").checked = false;
        document.getElementById(id + "Begginer").disabled = true;

        document.getElementById(id + "Mediator").checked = false;
        document.getElementById(id + "Mediator").disabled = true;

        document.getElementById(id + "Expert").checked = false;
        document.getElementById(id + "Expert").disabled = true;
    }
}

function validate() {
    const expEle = document.getElementById("expContent").children;
    for (let i = 0; i < expEle.length; i++) {
        for (let j = 0; i < 4; j++) {
            if (expEle[i].children[j].children[3]) {
                expEle[i].children[j].children[3].style.display = 'none';
            }
            
            if (expEle[i].children[j].children[2].value.trim() == '') {
                document.getElementById("3").style.display = 'block';
                document.getElementById("5").style.display = 'none'
                expEle[i].children[j].children[2].focus();
                const node = document.createElement("span");
                const text = document.createTextNode("This Field is mendatory");
                node.appendChild(text);
                node.style.color = 'red';
                expEle[i].children[j].appendChild(node);
                return false;
            }
        }
    }
    return true;
}

function prev(id) {
    document.getElementById(id).style.display = 'none';
    document.getElementById(Number(id) - 1).style.display = 'block'
}

function next(id) {
    document.getElementById(id).style.display = 'none';
    document.getElementById(Number(id) + 1).style.display = 'block'
}