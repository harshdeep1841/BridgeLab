using BrowserManager.Models;
using ConsoleAppLearning1.Learning.BrowserManager;

namespace TestProject2;

using BrowserManager.Managers;


[TestFixture]
public class BrowserManagerTest
{
    BrowserHistory history;
    TabManager manager;
    BookmarkManager bookmark;
    [SetUp]
    public void SetUp()
    {
        history = new BrowserHistory();
        manager = new TabManager();
        bookmark = new BookmarkManager();
    }
    [Test]
    public void Visit_ShouldUpdateCurrentUrl()
    {

        history.Visit("google.com");

        Assert.That(history.CurrentUrl, Is.EqualTo("google.com"));
    }

    [Test]
    public void Back_ShouldMoveToPreviousPage()
    {

        history.Visit("google.com");
        history.Visit("youtube.com");

        history.Back();

        Assert.That(history.CurrentUrl, Is.EqualTo("google.com"));
    }

    [Test]
    public void Forward_ShouldMoveToNextPage()
    {

        history.Visit("google.com");
        history.Visit("youtube.com");

        history.Back();
        history.Forward();

        Assert.That(history.CurrentUrl, Is.EqualTo("youtube.com"));
    }
    
        [Test]
        public void OpenTab_ShouldCreateCurrentTab()
        {

            manager.OpenTab("Google");

            Assert.That(manager.CurrentTab, Is.Not.Null);
            Assert.That(manager.CurrentTab.Title, Is.EqualTo("Google"));
        }

        [Test]
        public void SwitchToNextTab_ShouldMoveToNextTab()
        {

            manager.OpenTab("Google");
            manager.OpenTab("GitHub");

            manager.SwitchToNextTab();

            Assert.That(manager.CurrentTab.Title, Is.EqualTo("Google"));
        }

        [Test]
        public void SwitchToNextTab_WithSingleTab_ShouldStayOnSameTab()
        {

            manager.OpenTab("Google");

            manager.SwitchToNextTab();

            Assert.That(manager.CurrentTab.Title, Is.EqualTo("Google"));
        }

        [Test]
        public void CloseCurrentTab_ShouldMoveToNextAvailableTab()
        {

            manager.OpenTab("Google");
            manager.OpenTab("GitHub");


            manager.CloseCurrentTab();

            Assert.That(manager.CurrentTab.Title, Is.EqualTo("Google"));
        }

        [Test]
        public void CloseOnlyTab_ShouldLeaveNoTabs()
        {
            

            manager.OpenTab("Google");

            manager.CloseCurrentTab();

            Assert.That(manager.CurrentTab, Is.Null);
        }

        [Test]
        public void BookMark_Get()
        {
            manager.OpenTab("Google");
            manager.OpenTab("GitHub");
            manager.OpenTab("Youtube");
            bookmark.AddBookmark("Youtube", "https://youtube.com");
            bookmark.AddBookmark("Google", "https://google.com");
            bookmark.AddBookmark("Github", "https://github.com");
            Assert.That( bookmark.Search("Google") , Is.Not.Null);
        }
    }
    
