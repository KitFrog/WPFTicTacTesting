using NUnit.Framework;
using TicTacToeWPF;
using System.Threading;
using System.Windows.Controls;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace TicTacToeWPF.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void MainWindow_CreatedMainWindowd_MainWindowTurned()
        {
            // Arrange
            MainWindow window = new MainWindow();

            //Act

            var actual = window.Title;

            //Assert

            var expected = "MainWindow";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void ArtificialIntelligence_PerformEasyMove_ButtonIsDisabledButtonAndContentIsAISymbol()
        {
            //Arrange
            MainWindow mainWindow = new MainWindow();
            var buttons = mainWindow.GameButtons;

            //Act
            ArtificialIntelligence artificialIntelligence = new ArtificialIntelligence();
            ArtificialIntelligence.performEasyMove(buttons);

            var actual = buttons.Any(el => el.IsEnabled == false && el.Content == ArtificialIntelligence.AI_SYMBOL);

            //Assert
            Assert.That(actual, Is.True);
        }
        
        [Test]
        [Apartment(ApartmentState.STA)]
        public void ArtificialIntelligence_PerformHardMove_ButtonIsDisabledAndContentIsAISymbol()
        {
            //Arrange
            MainWindow mainWindow = new MainWindow();
            var buttons = mainWindow.GameButtons;

            //Act
            ArtificialIntelligence artificialIntelligence = new ArtificialIntelligence();
            ArtificialIntelligence.performHardMove(buttons);

            var actual = buttons.Any(el => el.IsEnabled == false && el.Content == ArtificialIntelligence.AI_SYMBOL);

            //Assert
            Assert.That(actual, Is.True);
        }
        [Test]
        [Apartment(ApartmentState.STA)]
        public void ArtificialIntelligence_CheckForDiagonalWin_DiagonalLeftToRight()
        {
            //Arrrange
            MainWindow window = new MainWindow();
            var buttons = window.GameButtons;

            buttons[0].Content = ArtificialIntelligence.AI_SYMBOL;
            buttons[4].Content = ArtificialIntelligence.AI_SYMBOL;
            buttons[8].Content = ArtificialIntelligence.AI_SYMBOL;

            //ACT
            var actual = ArtificialIntelligence.checkForDiagonalWin(buttons);

            //Assert
            Assert.That(actual, Is.True);
        }
        [Test]
        [Apartment(ApartmentState.STA)]
        public void ArtificialIntelligence_CheckForDiagonalWin_DiagonalRightToLeft()
        {
            //Arrrange
            MainWindow window = new MainWindow();
            var buttons = window.GameButtons;

            buttons[2].Content = ArtificialIntelligence.AI_SYMBOL;
            buttons[4].Content = ArtificialIntelligence.AI_SYMBOL;
            buttons[8].Content = ArtificialIntelligence.AI_SYMBOL;

            //ACT
            var actual = ArtificialIntelligence.checkForDiagonalWin(buttons);

            //Assert
            Assert.That(actual, Is.True);
        }
        [Test]
        [Apartment(ApartmentState.STA)]
        public void ArtificialIntelligence_CheckForEnemyDiagonalWin_DiagonalLeftToRight()
        {
            //Arrrange
            MainWindow window = new MainWindow();
            var buttons = window.GameButtons;

            buttons[0].Content = ArtificialIntelligence.ENEMY_SYMBOL;
            buttons[4].Content = ArtificialIntelligence.ENEMY_SYMBOL;
            buttons[8].Content = ArtificialIntelligence.ENEMY_SYMBOL;

            //ACT
            var actual = ArtificialIntelligence.checkForEnemyDiagonalWin(buttons);

            //Assert
            Assert.That(actual, Is.True);
        }
        [Test]
        [Apartment(ApartmentState.STA)]
        public void ArtificialIntelligence_CheckForEnemyDiagonalWin_DiagonalRightToLeft()
        {
            //Arrrange
            MainWindow window = new MainWindow();
            var buttons = window.GameButtons;

            buttons[2].Content = ArtificialIntelligence.ENEMY_SYMBOL;
            buttons[4].Content = ArtificialIntelligence.ENEMY_SYMBOL;
            buttons[8].Content = ArtificialIntelligence.ENEMY_SYMBOL;

            //ACT
            var actual = ArtificialIntelligence.checkForEnemyDiagonalWin(buttons);

            //Assert
            Assert.That(actual, Is.True);
        }
    }
}