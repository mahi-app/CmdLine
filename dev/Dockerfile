FROM mcr.microsoft.com/dotnet/sdk:5.0.101

# Install missing 'ps' command that some VS Code extensions depend on:
RUN apt-get update && \
    apt-get install -y procps

RUN groupadd -g 1000 -r mahi && \
    useradd -u 1000 -r -g mahi -m -s $(which bash) mahi
# Option '-m' to create home directory (see https://askubuntu.com/a/393470)
# Option '-s' to set  shell for this user (see comment in https://askubuntu.com/a/393470)
# Option '-r' creates a system user which does not expire 
#             (see https://linuxize.com/post/how-to-create-users-in-linux-using-the-useradd-command/)

# Create working directory. Ownership will be changed in entrypoint.sh which
# executes *after* the volume has been mounted.
RUN mkdir /app
RUN mkdir /app/dev

# Copy entrypoint script into container, make it executable, then execute it:
COPY entrypoint.sh /entrypoint.sh
RUN chmod +x /entrypoint.sh
ENTRYPOINT ["/entrypoint.sh"]
