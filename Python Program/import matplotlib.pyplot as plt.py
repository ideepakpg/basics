import matplotlib.pyplot as plt

# Create a figure and axis
fig, ax = plt.subplots()

# Draw Heisenberg's head
head = plt.Circle((0,0), radius=0.5, color='black')
ax.add_artist(head)

# Draw Heisenberg's eyes
left_eye = plt.Circle((-0.2, 0.2), radius=0.1, color='white')
ax.add_artist(left_eye)

right_eye = plt.Circle((0.2, 0.2), radius=0.1, color='white')
ax.add_artist(right_eye)

# Draw Heisenberg's pupils
left_pupil = plt.Circle((-0.2, 0.2), radius=0.05, color='black')
ax.add_artist(left_pupil)

right_pupil = plt.Circle((0.2, 0.2), radius=0.05, color='black')
ax.add_artist(right_pupil)

# Draw Heisenberg's nose
nose = plt.Polygon([[-0.1, 0.1], [0.1, 0.1], [0, 0]], color='black')
ax.add_artist(nose)

# Draw Heisenberg's mouth
ax.plot([-0.3, 0.3], [-0.1, -0.1], color='black')

# Draw Heisenberg's hat
hat = plt.Rectangle((-0.5, 0.5), 1, 0.2, color='black')
ax.add_artist(hat)

# Draw Heisenberg's hat brim
brim = plt.Rectangle((-0.6, 0.7), 1.2, 0.1, color='black')
ax.add_artist(brim)

# Set the axis limits
ax.set_xlim([-1, 1])
ax.set_ylim([-1, 1])

# Hide the axis
ax.axis('off')

# Show the figure
plt.show()
