import { Button } from "./Button";
import { CheckBox } from "./CheckBox";
import { Component } from "./Component";
import { IComponentMediator } from "./IComponentMediator";
import { TextBox } from "./TextBox";

export class AuthenticationDialog implements IComponentMediator {
    title: string = "Authentication";

    dialogMode = new CheckBox(this);

    loginUserName = new TextBox(this);

    loginPassword = new TextBox(this);

    regUserName = new TextBox(this);

    regPassword = new TextBox(this);

    regName = new TextBox(this);

    okButton = new Button(this);

    formValue?:
        | {
              mode: "Login";
              userName: string | null;
              password: string | null;
              name?: undefined;
          }
        | {
              mode: "Register";
              name: string | null;
              userName: string | null;
              password: string | null;
          };

    notify(sender: Component, event: string): void {
        const getCurrentMode = () => (this.dialogMode.isChecked ? "Login" : "Register");

        if (sender === this.dialogMode && event === "CHECK") this.title = getCurrentMode();

        const mode = getCurrentMode();
        this.formValue = this.extractFormValue(mode);
    }

    extractFormValue(mode: "Login" | "Register") {
        return mode === "Login"
            ? {
                  mode,
                  userName: this.loginUserName.value,
                  password: this.loginPassword.value,
              }
            : {
                  mode,
                  name: this.regName.value,
                  userName: this.regName.value,
                  password: this.regPassword.value,
              };
    }

    toString() {
        return `Title: ${this.title}\nFormValue: ${JSON.stringify(
            this.formValue ?? null,
            null,
            2
        )}`;
    }
}
