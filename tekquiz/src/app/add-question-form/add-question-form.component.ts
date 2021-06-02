import { Component, OnInit } from '@angular/core';
import {NgForm} from '@angular/forms';


@Component({
  selector: 'app-add-question-form',
  templateUrl: './add-question-form.component.html',
  styleUrls: ['./add-question-form.component.css']
})
export class AddQuestionFormComponent implements OnInit {

  public QuestionText:string;
  constructor() { }



  ngOnInit(): void {


  }

  onSubmit(addquestionform){
    console.log(addquestionform);
  }
  
}
