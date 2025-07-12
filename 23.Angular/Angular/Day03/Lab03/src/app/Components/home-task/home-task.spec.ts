import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HomeTask } from './home-task';

describe('HomeTask', () => {
  let component: HomeTask;
  let fixture: ComponentFixture<HomeTask>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [HomeTask]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HomeTask);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
