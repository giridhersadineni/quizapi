import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { QuestionService } from '../services/question.service';

@Component({
  selector: 'app-managequestions',
  templateUrl: './managequestions.component.html',
  styleUrls: ['./managequestions.component.css']
})
export class ManagequestionsComponent implements OnInit {

  public questions : any;

  constructor(private questionService:QuestionService) {
    
  }

  ngOnInit(): void {
   this.questionService.getallquestions()
   .subscribe((data)=>{
    this.questions=data;
   });
  }


}
