import { DailyHTemplatePage } from './app.po';

describe('DailyH App', function() {
  let page: DailyHTemplatePage;

  beforeEach(() => {
    page = new DailyHTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
