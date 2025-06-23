-- Insert sample data into Reservations table
INSERT INTO [dbo].[Reservations] 
    ([RoomID], [CustomerID], [ReservationMade], [CheckinDateTime], [CheckoutDateTime], [TotalGuests], [Nights], [ReservationStatus], [PaymentStatus], [Balance], [Notes])
VALUES
    (1, 3, '2024-08-01', '2024-08-05 14:00:00', '2024-08-10 11:00:00', 2, 5, 'Reserved', 'Paid', 0.00, 'N/A'),
    (2, 8, '2024-08-02', '2024-08-05 15:00:00', '2024-08-12 12:00:00', 4, 7, 'Reserved', 'Unpaid', 250.00, 'Requires late check-out'),
    (3, 13, '2024-08-03', '2024-08-06 13:00:00', '2024-08-10 10:00:00', 1, 4, 'Reserved', 'Pending', 100.00, 'No special requests'),
    (4, 16, '2024-08-04', '2024-08-07 16:00:00', '2024-08-14 14:00:00', 3, 7, 'Reserved', 'Paid', 0.00, 'Allergy to feathers'),
    (5, 19, '2024-08-05', '2024-08-05 14:00:00', '2024-08-10 11:00:00', 2, 5, 'Cancelled', 'Refunded', 50.00, 'Cancelled due to flight changes');

-- Insert additional sample data into Reservations table
INSERT INTO [dbo].[Reservations] 
    ([RoomID], [CustomerID], [ReservationMade], [CheckinDateTime], [CheckoutDateTime], [TotalGuests], [Nights], [ReservationStatus], [PaymentStatus], [Balance], [Notes])
VALUES
    (1, 19, '2024-08-06', '2024-08-10 14:00:00', '2024-08-15 11:00:00', 2, 5, 'Reserved', 'Unpaid', 200.00, 'Requires extra bed'),
    (2, 13, '2024-08-07', '2024-08-11 15:00:00', '2024-08-18 12:00:00', 3, 7, 'Reserved', 'Paid', 0.00, 'N/A'),
    (3, 8, '2024-08-08', '2024-08-12 13:00:00', '2024-08-17 10:00:00', 4, 5, 'Cancelled', 'Refunded', 100.00, 'Changed plans'),
    (4, 3, '2024-08-09', '2024-08-14 16:00:00', '2024-08-21 14:00:00', 2, 7, 'Reserved', 'Paid', 0.00, 'Late check-in'),
    (5, 16, '2024-08-10', '2024-08-15 14:00:00', '2024-08-20 11:00:00', 1, 5, 'Reserved', 'Unpaid', 150.00, 'Special dietary requests'),
    (1, 8, '2024-08-11', '2024-08-16 14:00:00', '2024-08-22 11:00:00', 3, 6, 'Reserved', 'Paid', 0.00, 'N/A'),
    (2, 19, '2024-08-12', '2024-08-17 15:00:00', '2024-08-23 12:00:00', 2, 6, 'Pending', 'Pending', 200.00, 'Early check-in requested'),
    (3, 13, '2024-08-13', '2024-08-18 13:00:00', '2024-08-24 10:00:00', 4, 6, 'Reserved', 'Paid', 0.00, 'N/A'),
    (4, 19, '2024-08-14', '2024-08-20 16:00:00', '2024-08-27 14:00:00', 3, 7, 'Reserved', 'Unpaid', 300.00, 'Requires late check-out'),
    (5, 16, '2024-08-15', '2024-08-22 14:00:00', '2024-08-29 11:00:00', 2, 7, 'Reserved', 'Paid', 0.00, 'N/A');
